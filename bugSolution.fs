let x = 10
let y = 20

let add x y = 
    let newX = x + y
    let newY = y + newX
    (newX, newY, newX + newY)

let (xResult, yResult, result) = add x y
printf "%d %d %d" xResult yResult result // Correct output