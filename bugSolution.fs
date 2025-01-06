let swap x y =
    let temp = x, y
    (snd temp, fst temp)

let x = 1
let y = 2

let x', y' = swap x y
printf "%d %d" x' y' //This will print 2 1 as expected