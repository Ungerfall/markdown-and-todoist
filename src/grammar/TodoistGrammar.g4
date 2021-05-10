grammar TodoistGrammar;

options
{
    language=CSharp;
}

/**
    lexer rules
*/
SHARP : '#';
PERCENT : '%';
DATETIMESEPARATOR : 'T';
HYPHEN : '-';
COLON : ':';
DIGIT : [0-9];
INT2 : DIGIT DIGIT;
INT4 : DIGIT DIGIT DIGIT DIGIT;
NEWLINE : '\r'? '\n' | '\r';
PERIOD : '.';
SPACE : ' ';
TEXT : [a-zA-Z0-9];


/**
    parser rules 
*/

project : SHARP inline+ date NEWLINE (task | subtask)* EOF?;

task : DIGIT+ PERIOD inline+ date NEWLINE?;

subtask : SPACE SPACE DIGIT+ PERIOD inline+ date NEWLINE?;

date
    : PERCENT INT4 HYPHEN INT2 HYPHEN INT2 DATETIMESEPARATOR INT2 COLON INT2 COLON INT2 PERCENT
    ;

inline : TEXT
    | SHARP
    | PERCENT
    | DATETIMESEPARATOR
    | HYPHEN
    | COLON
    | DIGIT
    | INT2
    | INT4
    | PERIOD
    | SPACE
    ;