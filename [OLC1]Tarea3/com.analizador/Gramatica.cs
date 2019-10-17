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
            var INICIO = new NonTerminal("INICIO");
            var L_INSTRUCCIONES = new NonTerminal("L_INSTRUCCIONES");
            var INSTRUCCION = new NonTerminal("INSTRUCCION");
            var IMPRIMIR = new NonTerminal("IMPRIMIR");
            var DECLARACION = new NonTerminal("DECLARACION");
            var TIPO = new NonTerminal("TIPO");
            var E = new NonTerminal("E");
            #endregion

            #region Terminales
            //Palabras reservadas
            var timprimir = ToTerm("imprimir");
            var tint = ToTerm("int");
            var tstring = ToTerm("string");
            
            //Symbols
            var puntoycoma = ToTerm(";");
            var para = ToTerm("(");
            var parc = ToTerm(")");
            var igual = ToTerm("=");
            #endregion

            #region ER
            IdentifierTerminal tokenId = new IdentifierTerminal("identificador", "_", "");
            RegexBasedTerminal tokenEntero = new RegexBasedTerminal("int", "[0-9]+");
            StringLiteral tokenCadena = new StringLiteral("string", "\"");

            CommentTerminal comentLinea = new CommentTerminal("SingleLineComment", ">>", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal comentMulti = new CommentTerminal("DelimitedComment", "<-", "->");
            NonGrammarTerminals.Add(comentLinea);
            NonGrammarTerminals.Add(comentMulti);
            #endregion

            #region Gramatica
            INICIO.Rule             =   L_INSTRUCCIONES;

            L_INSTRUCCIONES.Rule    =   MakePlusRule(L_INSTRUCCIONES, INSTRUCCION);

            INSTRUCCION.Rule        =   IMPRIMIR
                                    |   DECLARACION;

            IMPRIMIR.Rule           =   timprimir + para + E + parc + puntoycoma;

            DECLARACION.Rule        =   TIPO + tokenId + igual + E + puntoycoma
                                    |   TIPO + tokenId + puntoycoma;

            TIPO.Rule               =   tint
                                    |   tstring;

            E.Rule                  =   tokenEntero
                                    |   tokenCadena
                                    |   tokenId;
            #endregion

            #region Preferencias
            this.Root = INICIO;

            this.MarkTransient(E, TIPO, INSTRUCCION);

            this.MarkPunctuation(para, parc, puntoycoma, timprimir);
            #endregion
        }

    }
}