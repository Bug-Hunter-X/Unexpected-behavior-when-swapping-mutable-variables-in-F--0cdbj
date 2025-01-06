let mutable x = 1
let mutable y = 2

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 2 2, not 1 2 as expected because F# mutable variables are passed by sharing, not by value. 