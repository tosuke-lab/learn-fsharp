open System

let [|N; A; B|] = stdin.ReadLine().Split() |> Array.map int

let rec ketaSum x = (x % 10) + (if x < 10 then 0 else ketaSum (x / 10))

let result = 
  seq {
    for n in 1..N do
      let s = ketaSum n
      if A <= s && s <= B then yield n else ()
  } |> Seq.sum

printfn "%d" result