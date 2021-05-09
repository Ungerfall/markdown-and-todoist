grammar TodoistGrammar;

options
{
    language=CSharp;
}

/**
    lexer rules
*/
SHARP: '#';
PERCENT: '%';
DATETIMESEPARATOR: 'T';
HYPHEN: '-';
COLON: ':';
INT4: DIGIT DIGIT DIGIT DIGIT;
INT2: DIGIT DIGIT;
NEWLINE: '\r'? '\n' | '\r';

fragment DIGIT : [0-9];

/**
    parser rules 
*/

project: (date NEWLINE?)+;
date
    : PERCENT INT4 HYPHEN INT2 HYPHEN INT2 DATETIMESEPARATOR INT2 COLON INT2 COLON INT2 PERCENT
    ;