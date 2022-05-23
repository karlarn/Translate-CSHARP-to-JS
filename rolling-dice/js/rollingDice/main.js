// Put your code here
console.log("Let's roll some dice, baby!")
console.log("---------------------------")

const changeToString=(num)=>{
    if (num===1){
        return "one"
    }
    else if(num===2){
        return "two"
    }
    else if(num===3){
        return "three"
    }
    else if (num===4){
        return "four"
    }
    else if(num===5){
        return "five"
    }
    else if(num===6){
        return "six"
    }
}

for (i=1;i<=10;i++){
    let diceOne=Math.ceil(Math.random()*6)
    let diceTwo=Math.ceil(Math.random()*6)
    let stringOne=changeToString(diceOne)
    let stringTwo=changeToString(diceTwo)
    if (diceOne===diceTwo){
        console.log(`${stringOne} + ${stringTwo} == ${diceOne+diceTwo} DOUBLES!`)    
    }
    else {console.log(`${stringOne} + ${stringTwo} == ${diceOne+diceTwo}`)}
}