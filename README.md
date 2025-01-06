# F# Mutable Variable Swap Bug

This repository demonstrates a common issue encountered when working with mutable variables in F#. The `swap` function, as implemented in `bug.fs`, doesn't work as intended due to F#'s pass-by-sharing behavior for mutable variables. The solution in `bugSolution.fs` corrects the issue.

## Bug Description
The `swap` function aims to exchange the values of two mutable variables. However, because F# passes mutable variables by sharing, the function modifies the original variables directly.  This leads to both variables having the same value after the swap.

## Solution
The solution involves creating a new tuple to hold the swapped values. This prevents direct modification of the original variables, preserving their intended values after the swap.

## How to reproduce:
1. Clone the repository
2. Open `bug.fs` and run the code. Observe the unexpected output.
3. Open `bugSolution.fs` and run the code. Observe the corrected output.
