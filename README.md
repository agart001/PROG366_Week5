# PROG366_Week5
The Fisher–Yates shuffle was first described in 1938 by Ronald Fisher and Frank Yates in their book Statistical tables for biological, agricultural and medical research. It generates a random permutation (shuffle) of a finite sequence.

The algorithm produces an unbiased permutation (every permutation is equally likely).

From Wikipedia:

Their description of the algorithm used pencil and paper; a table of random numbers provided the randomness. The basic method given for generating a random permutation of the numbers 1 through  goes as follows:

-Write down the numbers from 1 through .
-Pick a random number  between one and the number of unstruck numbers remaining (inclusive).
-Counting from the low end, strike out the th number not yet struck out, and write it down at the end of a separate list.
-Repeat from step 2 until all the numbers have been struck out.
-The sequence of numbers written down in step 3 is now a random permutation of the original numbers.

Provided that the random numbers picked in step 2 above are truly random and unbiased, so will be the resulting permutation. Fisher and Yates took care to describe how to obtain such random numbers in any desired range from the supplied tables in a manner which avoids any bias. 