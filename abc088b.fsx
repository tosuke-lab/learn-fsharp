open System

stdin.ReadLine()

let a = stdin.ReadLine().Split() |> Array.map int

let total = Array.sum a

let alice =
  a
  |> Array.sortDescending
  |> Array.mapi (fun i x -> (i, x))
  |> Seq.filter (fun (i, _) -> i % 2 = 0)
  |> Seq.fold (fun s (_, x) -> s + x) 0

let bob = total - alice

printfn "%d" (alice - bob)