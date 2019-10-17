using _OLC1_Tarea3.global;
using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.com.analizador
{
    class Sintactico
    {

        public static bool analizar(String cadena, String nombrePestana)
        {
            bool retorno = true;
            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(cadena);
            ParseTreeNode raiz = arbol.Root;

            for (int i = 0; i < arbol.ParserMessages.Count; i++)
            {
                if (arbol.ParserMessages[i].Message.Contains("Invalid character"))
                {
                    Program.erroresLexicos.Add(new vista.Error(arbol.ParserMessages[i].Message.Split('\'', '\'')[1], "Caracter inválido.", arbol.ParserMessages[i].Location.Line + 1, arbol.ParserMessages[i].Location.Column + 1, nombrePestana));
                    Program.ventanaPrincipal.richConsola.AppendText(arbol.ParserMessages[i].Message.Split('\'', '\'')[1] + ". Caracter inválido. Línea: " + (arbol.ParserMessages[i].Location.Line + 1) + " Columna: " + (arbol.ParserMessages[i].Location.Column + 1));
                }
                else if (arbol.ParserMessages[i].Message.Contains("Syntax error, expected"))
                {
                    Program.erroresSintacticos.Add(new vista.Error(arbol.Tokens[arbol.Tokens.Count - 1].ToString(), "Se esperaba: " + arbol.ParserMessages[i].Message.Split(':')[1] + ".", arbol.ParserMessages[i].Location.Line + 1, arbol.ParserMessages[i].Location.Column + 1, nombrePestana));
                    Program.ventanaPrincipal.richConsola.AppendText(arbol.Tokens[arbol.Tokens.Count - 1].ToString() + ". Se esperaba: " + arbol.ParserMessages[i].Message.Split(':')[1] + ". Línea: " + (arbol.ParserMessages[i].Location.Line + 1) + " Columna: " + (arbol.ParserMessages[i].Location.Column + 1));
                }

            }

            if (raiz == null)
            {
                retorno = false;
            } else 
            {
                generarArbol(raiz, nombrePestana);
                
                //Aqui se llamara el codigo para leer el arbol
                compilarArbol(raiz, null);
            }
            return retorno;
            

        }

        private static void generarArbol(ParseTreeNode root, String nombrePestana)
        {
            String grafoDOT = com.vista.ControlDOT.getDOT(root);
            string nombreArchivo = Path.GetDirectoryName(Environment.CurrentDirectory) + "\\" + nombrePestana + ".dot";
            FileStream fileStream = new FileStream(nombreArchivo, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream, System.Text.Encoding.Default);
            streamWriter.WriteLine(grafoDOT);
            streamWriter.Close();
            generarImagen(nombrePestana);
        }

        private static void generarImagen(String nombrePestana)
        {
            Process consola = new Process();
            consola.StartInfo.FileName = "cmd.exe";
            consola.StartInfo.RedirectStandardInput = true;
            consola.StartInfo.RedirectStandardOutput = true;
            consola.StartInfo.CreateNoWindow = true;
            consola.StartInfo.UseShellExecute = false;
            consola.Start();
            consola.StandardInput.WriteLine("cd " + Path.GetDirectoryName(Environment.CurrentDirectory));
            consola.StandardInput.WriteLine("dot -Tjpg " + nombrePestana + ".dot -o " + nombrePestana + ".jpg");
            consola.StandardInput.Flush();
            consola.StandardInput.Close();
            consola.WaitForExit();
        }

        private static void compilarArbol(ParseTreeNode raiz, Entorno ent)
        {
            string inicio = raiz.ToString();
            ParseTreeNode[] hijos = null;
            if (raiz.ChildNodes.Count > 0)
            {
                hijos = raiz.ChildNodes.ToArray();
            }

            switch (inicio)
            {
                case "INICIO":
                    {
                        Entorno nuevoEntorno = new Entorno(ent);
                        foreach (ParseTreeNode hijo in hijos)
                        {
                            compilarArbol(hijo, nuevoEntorno);
                        }
                       
                    }
                    break;

                case "L_INSTRUCCIONES":
                    {
                        foreach (ParseTreeNode hijo in hijos)
                        {
                            compilarArbol(hijo, ent);
                        }
                        
                    }
                    break;

                case "IMPRIMIR":
                    {
                        ejecutarImprimir(hijos[0], ent);
                    }
                    break;

                case "DECLARACION":
                    {
                        ejecutarDeclaracion(raiz, ent);
                    }
                    break;
            }
        }

        private static void ejecutarImprimir(ParseTreeNode raiz, Entorno ent)
        {
            Expresion resultado = resolverExpresion(raiz, ent);

            if(resultado != null) 
            {
                if (resultado.tipo != Simbolo.EnumTipo.error)
                {
                    if (resultado.valor != null)
                    {
                        Program.ventanaPrincipal.richConsola.AppendText(resultado.valor.ToString() + "\n");
                    }
                    else
                    {
                        Program.ventanaPrincipal.richConsola.AppendText("La variable no ha sido previamente inicializada. Línea: " + (raiz.Token.Location.Line + 1) + " Columna: " + (raiz.Token.Location.Column + 1) + "\n");
                    }

                }
                else
                {
                    Program.ventanaPrincipal.richConsola.AppendText(resultado.error + "\n");
                }
            }
        }

        private static void ejecutarDeclaracion(ParseTreeNode raiz, Entorno ent)
        {
            ParseTreeNode[] hijos = raiz.ChildNodes.ToArray();
            Simbolo.EnumTipo tipoVariable = obtenerTipo(hijos[0].ToString().Replace(" (Keyword)", ""));
            String id = hijos[1].Token.ValueString;

            if (hijos.Length > 2) 
            {
                Expresion resultado = resolverExpresion(hijos[3], ent);
                if (tipoVariable != resultado.tipo)
                {
                    Program.ventanaPrincipal.richConsola.AppendText("El tipo que se le quiere asignar a la variable '" + id + "' no es permitido. '" + tipoVariable + "' != '" + resultado.tipo + "'. Línea: " + (hijos[3].Token.Location.Line + 1) + " Columna: " + (hijos[3].Token.Location.Column + 1) + "\n");
                    return;
                }
                Simbolo nuevo = new Simbolo(tipoVariable, resultado.valor);
                ent.insertar(id, nuevo, hijos[1].Token.Location.Line + 1, hijos[1].Token.Location.Column + 1);
            } else 
            {
                ent.insertar(id, new Simbolo(), hijos[1].Token.Location.Line + 1, hijos[1].Token.Location.Column + 1);
            }

        }

        private static Simbolo.EnumTipo obtenerTipo(String tipo)
        {
            switch (tipo.ToLower())
            {
                case "int":
                    return Simbolo.EnumTipo.entero;
                case "string":
                    return Simbolo.EnumTipo.cadena;
                default:
                    return Simbolo.EnumTipo.error;
            }
        }

        private static Expresion resolverExpresion(ParseTreeNode raiz, Entorno ent)
        {
            Expresion retorno = null;

            switch (raiz.Term.Name)
            {
                
                case "int":
                    {
                        retorno = new Expresion(Simbolo.EnumTipo.entero, raiz.Token.ValueString);
                    }
                    break;

                case "string":
                    {
                        retorno = new Expresion(Simbolo.EnumTipo.cadena, raiz.Token.ValueString);
                    }
                    break;
                case "identificador":
                    {
                        Simbolo sim = ent.buscar(raiz.Token.ValueString, raiz.Token.Location.Line + 1, raiz.Token.Location.Column + 1);
                        if(sim != null) {
                            retorno = new Expresion(sim.tipo, sim.valor);
                        } else 
                        {
                            Program.ventanaPrincipal.richConsola.AppendText("La variable no ha sido previamente declarada. Línea: " + (raiz.Token.Location.Line + 1) + " Columna: " + (raiz.Token.Location.Column + 1) + "\n");
                        }
                    }
                    break;
                default:
                {
                    retorno = new Expresion(Simbolo.EnumTipo.error, "Error", "No se reconoce el tipo. Línea: " + (raiz.Token.Location.Line + 1) + " Columna: " + (raiz.Token.Location.Column + 1));
                }
                    break;
        }
        return retorno;
    }

    }
}
