open System

let [|N; Y|] = stdin.ReadLine().Split() |> Array.map int

seq {
  for i in 0..N do
    for j in 0..(N-i) -> (i, j, N-i-j)
}
|> Seq.tryFind (fun (a, b, c) -> 10000 * a + 5000 * b + 1000 * c = Y)
|> (fun opt -> if Option.isSome opt then Option.get opt else (-1, -1, -1))
|> (fun (a, b, c) -> printfn "%d %d %d" a b c)