let xRef = ref 10
let yRef = ref 20
let zRef = ref 30

let swap xRef yRef =
    let temp = !xRef
    xRef := !yRef
    yRef := temp

swap xRef yRef
printfn "%d %d %d" !xRef !yRef !zRef