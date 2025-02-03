# Unexpected Output with Mutable Variables in F# Function

This example demonstrates a potential source of confusion when using mutable variables in F# functions. The `add` function modifies its input parameters, leading to an unexpected output.

The `bug.fs` file contains the buggy code, while `bugSolution.fs` provides a corrected version.

## Bug Description
The issue lies in how mutable variables are modified within the function. Modifying `x` and `y` simultaneously affects the calculation and final result.  The changes made to x and y in the function do not reflect what may intuitively be expected.