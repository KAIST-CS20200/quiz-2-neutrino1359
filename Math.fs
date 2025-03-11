module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  
  let rec f (n:int64) t=
    if n = 1 then t
    else if n % 2L = 0 then f (n / 2L) (t + 1)
    else f (3L * n + 1L) (t + 1)

  f n 0





