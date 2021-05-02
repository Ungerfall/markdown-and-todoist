// Define a grammar called Hello
grammar TodoistGrammar;
r  : 'hello' ID ;         // match keyword hello followed by an identifier
ID : [a-z]+ ;             // match lower-case identifiers
WS : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlinesva

/**
    lexer rules
*/
SHARP: '#';
PERCENT: '%';

fragment DIGIT : [0-9];