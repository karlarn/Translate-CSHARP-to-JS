// Put your code here
console.log("My Enemies List!")
console.log("----------------")

const ArrayOfEnemyObjects=[
    {FirstName : "Joshua",
    LastName : "Flowers",
    IsReallyHated : true},
    {FirstName : "Darth",
    LastName : "Vader",
    IsReallyHated: false},
    {FirstName : "Betty",
    LastName : "Rudelady",
    IsReallyHated: true},
    {FirstName : "Leon",
    LastName : "Peck",
    IsReallyHated:false}
]
for (let i of ArrayOfEnemyObjects){
    if (i.IsReallyHated){
        console.log(`${i.FirstName} ${i.LastName} (Really, really dislike!)`)
    }
    else {
        console.log(`${i.FirstName} ${i.LastName}`)
    }
}