function expressionSplit(expression) {
    console.log(expression.split(/[(),.;\s]+/).join('\n'));
}

expressionSplit('let sum = 4 * 4,b = "wow";');
expressionSplit('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}');