open System

let readInt () = stdin.ReadLine() |> int

let A = readInt ()
let B = readInt ()
let C = readInt ()
let X = readInt ()

let count =
  seq {
    for i in 0..A do
      for j in 0..B do
        let rest = X - (i * 500) - (j * 100)
        yield if 0 <= rest && rest <= (C * 50) then 1 else 0 
  } |> Seq.sum

printfn "%d" count