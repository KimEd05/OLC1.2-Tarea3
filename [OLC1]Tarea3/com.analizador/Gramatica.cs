using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace _OLC1_Tarea3.com.analizador
{
    class Gramatica : Grammar
    {
        public Gramatica() : base(caseSensitive: false)
        { 
            #region No Terminales
            var INICIAL = new NonTerminal("INICIAL");
            var AUX_INICIAL = new NonTerminal("INICIAL");
            var CLASS = new NonTerminal("CLASS");
            var IMPORT = new NonTerminal("IMPORT");
            var CONT_CLASS = new NonTerminal("CONT_CLASS");
            var DESC_CLASS = new NonTerminal("DESC_CLASS");
            var LISTA_ID = new NonTerminal("LISTA_ID");
            var DEC_VARIABLE = new NonTerminal("DEC_VARIABLE");
            var VISIBILIDAD = new NonTerminal("VISIBILIDAD");
            var TIPO = new NonTerminal("TIPO");
            var ASI_VARIABLE = new NonTerminal("ASI_VARIABLE");
            var BOOL = new NonTerminal("BOOL");
            var M_ATRI = new NonTerminal("M_ATRI");
            var CONDICION = new NonTerminal("CONDICION");
            var RELACION = new NonTerminal("RELACION");
            var SIGNO_REL = new NonTerminal("SIGNO_REL");
            var VALOR = new NonTerminal("VALOR");
            var ASIGNACION = new NonTerminal("ASIGNACION");
            var AUM_DEC = new NonTerminal("AUM_DEC");
            var SIGNO_AD = new NonTerminal("SIGNO_AD");
            var DEC_ARREGLO = new NonTerminal("DEC_ARREGLO");
            var DIMENSIONES = new NonTerminal("DIMENSIONES");
            var ASI_ARREGLO = new NonTerminal("ASI_ARREGLO");
            var DESC_ARREGLO = new NonTerminal("DESC_ARREGLO");
            var DIMEN_3 = new NonTerminal("DIMEN_3");
            var LISTA_3 = new NonTerminal("LISTA_3");
            var DIMEN_2 = new NonTerminal("DIMEN_2");
            var LISTA_2 = new NonTerminal("LISTA_2");
            var DIMEN_1 = new NonTerminal("DIMEN_1");
            var LISTA_1 = new NonTerminal("LISTA_1");
            var ASI_CLASE = new NonTerminal("ASI_CLASE");
            var ELE_CLASE = new NonTerminal("ELE_CLASE");
            var ANIDAR = new NonTerminal("ANIDAR");
            var INS_IND = new NonTerminal("INS_IND");
            var ELE_FUNCION = new NonTerminal("ELE_FUNCION");
            var DEC_FUNCION = new NonTerminal("DEC_FUNCION");
            var OVER = new NonTerminal("OVER");
            var ELE_PAR = new NonTerminal("ELE_PAR");
            var LISTA_FUNCION = new NonTerminal("LISTA_FUNCION");
            var TIPO_PARAM = new NonTerminal("TIPO_PARAM");
            var RETORNO = new NonTerminal("RETORNO");
            var SENT_IF = new NonTerminal("SENT_IF");
            var CONT_ELSE_IF = new NonTerminal("CONT_ELSE_IF");
            var ELSE_IF = new NonTerminal("ELSE_IF");
            var CICLO_FOR = new NonTerminal("CICLO_FOR");
            var ASIG_FOR = new NonTerminal("ASIG_FOR");
            var ACTUAL_FOR = new NonTerminal("ACTUAL_FOR");
            var CICLO_REPEAT = new NonTerminal("CICLO_REPEAT");
            var CICLO_WHILE = new NonTerminal("CICLO_WHILE");
            var CICLO_DO_WHILE = new NonTerminal("CICLO_DO_WHILE");
            var SALIDA = new NonTerminal("SALIDA");
            var SENT_COMPROBAR = new NonTerminal("SENT_COMPROBAR");
            var CONT_COMPROBAR = new NonTerminal("CONT_COMPROBAR");
            var AGREGAR_FIGURA = new NonTerminal("AGREGAR_FIGURA");
            var TIPO_FIGURA = new NonTerminal("TIPO_FIGURA");
            var COORDENADA = new NonTerminal("COORDENADA");
            #endregion

            #region Terminales
            //Palabras reservadas
            var clase = ToTerm("clase");
            var importar = ToTerm("importar");
            var publico = ToTerm("publico");
            var privado = ToTerm("privado");
            var tentero = ToTerm("int");
            var tdouble = ToTerm("double");
            var tbool = ToTerm("bool");
            var tchar = ToTerm("char");
            var tstring = ToTerm("string");
            var verdadero = ToTerm("verdadero");
            var falso = ToTerm("falso");
            var ttrue = ToTerm("true");
            var tfalse = ToTerm("false");
            var array = ToTerm("array");
            var tnew = ToTerm("new");
            var tvoid = ToTerm("void");
            var toverride = ToTerm("override");
            var treturn = ToTerm("return");
            var tmain = ToTerm("main");
            var print = ToTerm("print");
            var show = ToTerm("show");
            var tif = ToTerm("if");
            var telse = ToTerm("else");
            var tfor = ToTerm("for");
            var repeat = ToTerm("repeat");
            var twhile = ToTerm("while");
            var hacer = ToTerm("hacer");
            var mientras = ToTerm("mientras");
            var continuar = ToTerm("continuar");
            var salir = ToTerm("salir");
            var comprobar = ToTerm("comprobar");
            var caso = ToTerm("caso");
            var defecto = ToTerm("defecto");
            var addfigure = ToTerm("addfigure");
            var circle = ToTerm("circle");
            var triangle = ToTerm("triangle");
            var square = ToTerm("square");
            var line = ToTerm("line");
            var figure = ToTerm("figure");

            //Symbols
            var punto = ToTerm(".");
            var coma = ToTerm(",");
            var puntoycoma = ToTerm(";");
            var cora = ToTerm("[");
            var corc = ToTerm("]");
            var llaa = ToTerm("{");
            var llac = ToTerm("}");
            var para = ToTerm("(");
            var parc = ToTerm(")");
            var igual = ToTerm("=");
            var eq = ToTerm("==");
            var diferente = ToTerm("!=");
            var mas = ToTerm("+");
            var menos = ToTerm("-");
            var incremento = ToTerm("++");
            var decremento = ToTerm("--");
            var por = ToTerm("*");
            var dividido = ToTerm("/");
            var potencia = ToTerm("^");
            var dospuntos = ToTerm(":");
            var admc = ToTerm("!");
            var and = ToTerm("&&");
            var or = ToTerm("||");
            var menor = ToTerm("<");
            var mayor = ToTerm(">");
            var menorigual = ToTerm("<=");
            var mayorigual = ToTerm(">=");
            #endregion

            #region ER
            IdentifierTerminal tokenId = new IdentifierTerminal("identificador", "_", "");
            RegexBasedTerminal tokenDecimal = new RegexBasedTerminal("double", "[0-9]+[.][0-9]+");
            RegexBasedTerminal tokenEntero = new RegexBasedTerminal("int", "[0-9]+");
            StringLiteral tokenCadena = new StringLiteral("string", "\"");
            StringLiteral tokenCaracter = new StringLiteral("char", "\'");

            CommentTerminal comentLinea = new CommentTerminal("SingleLineComment", ">>", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal comentMulti = new CommentTerminal("DelimitedComment", "<-", "->");
            NonGrammarTerminals.Add(comentLinea);
            NonGrammarTerminals.Add(comentMulti);
            #endregion

            #region Gramatica
            INICIAL.Rule        =   AUX_INICIAL;
            
            AUX_INICIAL.Rule    =   MakePlusRule(AUX_INICIAL, CLASS);

            CLASS.Rule          =   clase + tokenId + IMPORT + llaa + CONT_CLASS + llac;   

            IMPORT.Rule         =   importar + LISTA_ID
                                |   Empty;

            LISTA_ID.Rule       =   MakeListRule(LISTA_ID, coma, tokenId);

            CONT_CLASS.Rule     =   MakePlusRule(CONT_CLASS, DESC_CLASS);

            DESC_CLASS.Rule     =   DEC_VARIABLE
                                |   ASIGNACION
                                |   AUM_DEC
                                |   DEC_ARREGLO
                                |   INS_IND
                                |   DEC_FUNCION
                                |   SENT_IF
                                |   CICLO_FOR
                                |   CICLO_REPEAT
                                |   CICLO_WHILE
                                |   CICLO_DO_WHILE
                                |   SALIDA
                                |   SENT_COMPROBAR
                                |   AGREGAR_FIGURA
                                |   Empty;

            ANIDAR.Rule         =   ANIDAR + punto + tokenId + ELE_CLASE
                                |   punto + tokenId + ELE_CLASE;

            INS_IND.Rule        =   tokenId + punto + tokenId + ASI_VARIABLE + puntoycoma
                                |   tokenId + ANIDAR + puntoycoma
                                |   tokenId + ELE_FUNCION + puntoycoma
                                |   VISIBILIDAD + tokenId + tokenId + ASI_CLASE + puntoycoma
                                |   tokenId + tokenId + ASI_CLASE + puntoycoma
                                |   print + para + LISTA_1 + parc + puntoycoma
                                |   show + para + VALOR + coma + VALOR + parc + puntoycoma
                                |   figure + para + VALOR + parc + puntoycoma;
            
            DEC_VARIABLE.Rule   =   VISIBILIDAD + TIPO + LISTA_ID + ASI_VARIABLE + puntoycoma
                                |   TIPO + LISTA_ID + ASI_VARIABLE + puntoycoma;

            VISIBILIDAD.Rule    =   publico
                                |   privado;

            TIPO.Rule           =   tentero
                                |   tdouble
                                |   tbool
                                |   tchar
                                |   tstring;

            ASI_VARIABLE.Rule   =   igual + CONDICION
                                |   Empty;

            CONDICION.Rule      =   CONDICION + and + admc + para + RELACION + parc
                                |   CONDICION + and + RELACION
                                |   CONDICION + or + admc + para + RELACION + parc 
                                |   CONDICION + or + RELACION 
                                |   admc + para + RELACION + parc 
                                |   admc + para + CONDICION + parc 
                                |   RELACION;

            RELACION.Rule       =   VALOR + SIGNO_REL + VALOR
                                |   para + VALOR + SIGNO_REL + VALOR + parc 
                                |   BOOL 
                                |   para + BOOL + parc 
                                |   admc + tokenId 
                                |   admc + BOOL 
                                |   VALOR 
                                |   para + CONDICION + parc;

            SIGNO_REL.Rule      =   eq
                                |   diferente 
                                |   menor 
                                |   menorigual 
                                |   mayor 
                                |   mayorigual;

            VALOR.Rule          =   VALOR + mas + VALOR
                                |   VALOR + menos + VALOR
                                |   VALOR + por + VALOR
                                |   VALOR + dividido + VALOR
                                |   VALOR + potencia + VALOR
                                |   VALOR + para + VALOR + parc
                                |   para + VALOR + parc
                                |   menos + VALOR
                                |   tokenId + para + M_ATRI + parc
                                |   tokenId + DIMENSIONES
                                |   tokenId + ELE_CLASE
                                |   tokenId + ANIDAR
                                |   tokenId
                                |   tokenEntero
                                |   tokenDecimal
                                |   BOOL
                                |   tokenCaracter
                                |   tokenCadena;

            M_ATRI.Rule         =   CONDICION
                                |   Empty;

            BOOL.Rule           =   verdadero
                                |   falso
                                |   ttrue
                                |   tfalse;

            ASIGNACION.Rule     =   tokenId + igual + CONDICION + puntoycoma
                                |   tokenId + DIMENSIONES + igual + CONDICION + puntoycoma;

            AUM_DEC.Rule        =   tokenId + SIGNO_AD + puntoycoma
                                |   tokenEntero + SIGNO_AD + puntoycoma
                                |   tokenDecimal + SIGNO_AD + puntoycoma
                                |   tokenCaracter + SIGNO_AD + puntoycoma;

            SIGNO_AD.Rule       =   incremento
                                |   decremento;

            DEC_ARREGLO.Rule    =   VISIBILIDAD + TIPO + array + LISTA_ID + DIMENSIONES + ASI_ARREGLO + puntoycoma
                                |   TIPO + array + LISTA_ID + DIMENSIONES + ASI_ARREGLO + puntoycoma;

            DIMENSIONES.Rule    =   cora + VALOR + corc
                                |   cora + VALOR + corc + cora + VALOR + corc
                                |   cora + VALOR + corc + cora + VALOR + corc + cora + VALOR + corc;

            ASI_ARREGLO.Rule    =   igual + DESC_ARREGLO
                                |   Empty;

            DESC_ARREGLO.Rule   =   DIMEN_1
                                |   DIMEN_2
                                |   DIMEN_3
                                |   tokenId + ELE_CLASE
                                |   tokenId + ANIDAR;

            DIMEN_3.Rule        =   llaa + LISTA_3 + llac;

            LISTA_3.Rule        =   LISTA_3 + coma + DIMEN_2
                                |   DIMEN_2;

            DIMEN_2.Rule        =   llaa + LISTA_2 + llac;

            LISTA_2.Rule        =   LISTA_2 + coma + DIMEN_1
                                |   DIMEN_1;

            DIMEN_1.Rule        =   llaa + LISTA_1 + llac;

            LISTA_1.Rule        =   LISTA_1 + coma + CONDICION
                                |   CONDICION;

            ASI_CLASE.Rule      =   igual + tnew + tokenId + para + parc
                                |   igual + tokenId + ANIDAR
                                |   igual + tokenId + ELE_CLASE
                                |   Empty;

            ELE_CLASE.Rule      =   para + LISTA_1 + parc
                                |   para + parc
                                |   Empty;

            DEC_FUNCION.Rule    =   VISIBILIDAD + tokenId + tvoid + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   VISIBILIDAD + tokenId + TIPO + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   VISIBILIDAD + tokenId + array + TIPO + DIMENSIONES + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   VISIBILIDAD + tokenId + tokenId + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   tokenId + tvoid + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   tokenId + TIPO + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   tokenId + array + TIPO + DIMENSIONES + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   tokenId + tokenId + OVER + ELE_PAR + llaa + CONT_CLASS + RETORNO + llac
                                |   tmain + para + parc + llaa + CONT_CLASS + llac;

            OVER.Rule           =   toverride
                                |   Empty;

            ELE_FUNCION.Rule    =   para + LISTA_1 + parc
                                |   para + parc;

            ELE_PAR.Rule        =   para + LISTA_FUNCION + parc
                                |   para + parc;

            LISTA_FUNCION.Rule  =   LISTA_FUNCION + coma + TIPO_PARAM + CONDICION
                                |   TIPO_PARAM + CONDICION;

            TIPO_PARAM.Rule     =   tentero
                                |   tdouble
                                |   tbool
                                |   tchar
                                |   tstring
                                |   tokenId;

            RETORNO.Rule        =   treturn + CONDICION + puntoycoma
                                |   Empty;

            SENT_IF.Rule        =   tif + para + CONDICION + parc + llaa + CONT_CLASS + RETORNO + llac
                                |   tif + para + CONDICION + parc + llaa + CONT_CLASS + RETORNO + llac + telse + llaa + CONT_CLASS + RETORNO + llac
                                |   tif + para + CONDICION + parc + llaa + CONT_CLASS + RETORNO + llac + CONT_ELSE_IF
                                |   tif + para + CONDICION + parc + llaa + CONT_CLASS + RETORNO + llac + CONT_ELSE_IF + telse + llaa + CONT_CLASS + RETORNO + llac;

            CONT_ELSE_IF.Rule   =   MakePlusRule(CONT_ELSE_IF, ELSE_IF);

            ELSE_IF.Rule        =   telse + tif + para + CONDICION + parc + llaa + CONT_CLASS + RETORNO + llac;

            CICLO_FOR.Rule      =   tfor + para + ASIG_FOR + puntoycoma + CONDICION + puntoycoma + ACTUAL_FOR + parc + llaa + CONT_CLASS + llac;

            ASIG_FOR.Rule       =   TIPO + tokenId + igual + VALOR
                                |   tokenId + igual + VALOR;

            ACTUAL_FOR.Rule     =   VALOR
                                |   VALOR + SIGNO_AD;

            CICLO_REPEAT.Rule   =   repeat + para + VALOR + parc + llaa + CONT_CLASS + llac;

            CICLO_WHILE.Rule    =   twhile + para + CONDICION + parc + llaa + CONT_CLASS + llac;

            CICLO_DO_WHILE.Rule =   hacer + llaa + CONT_CLASS + llac + mientras + para + CONDICION + parc + puntoycoma;

            SALIDA.Rule         =   continuar + puntoycoma
                                |   salir + puntoycoma;

            SENT_COMPROBAR.Rule =   comprobar + para + CONDICION + parc + llaa + CONT_COMPROBAR + llac;

            CONT_COMPROBAR.Rule =   CONT_COMPROBAR + caso + VALOR + dospuntos + CONT_CLASS
                                |   CONT_COMPROBAR + defecto + dospuntos + CONT_CLASS
                                |   caso + VALOR + dospuntos + CONT_CLASS
                                |   defecto + dospuntos + CONT_CLASS;

            AGREGAR_FIGURA.Rule =   addfigure + para + TIPO_FIGURA + parc + puntoycoma;

            TIPO_FIGURA.Rule    =   circle + para + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + parc
                                |   triangle + para + VALOR + coma + VALOR + coma + COORDENADA + coma + COORDENADA + coma + COORDENADA + parc
                                |   square + para + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + parc
                                |   line + para + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + coma + VALOR + parc;

            COORDENADA.Rule     =   VALOR + coma + VALOR;

            #endregion

            #region Preferencias
            this.Root = INICIAL;
            
            this.RegisterOperators(1, Associativity.Left, or);
            this.RegisterOperators(2, Associativity.Left, and);
            this.RegisterOperators(3, Associativity.Left, admc);
            this.RegisterOperators(4, Associativity.Left, eq, diferente, menor, menorigual, mayor, mayorigual);
            this.RegisterOperators(5, Associativity.Left, mas, menos);
            this.RegisterOperators(6, Associativity.Left, por, dividido);
            this.RegisterOperators(7, Associativity.Left, potencia);
            this.RegisterOperators(8, Associativity.Left, llaa, llac);
            this.RegisterOperators(9, Associativity.Left, tokenEntero, tokenDecimal);
            this.RegisterOperators(10, Associativity.Left, "void");

            this.MarkTransient(INICIAL, IMPORT, OVER, DESC_CLASS);
            this.MarkTransient(VISIBILIDAD, TIPO, TIPO_PARAM, ELE_PAR);
            this.MarkTransient(SIGNO_REL, BOOL, SALIDA, CONT_ELSE_IF);
            
            this.MarkPunctuation(clase, importar);
            this.MarkPunctuation(treturn, tif, telse);
            this.MarkPunctuation(coma, para, parc, llaa, llac, puntoycoma, igual);
            #endregion
        }

    }
}