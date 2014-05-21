Topological Sort
================

Topological sort is a very useful algorithm when it comes to detect and analyse dependencies.
In most modern languages this is automatically handled for you in the compilation process, but
languages like `JavaScript` require you to solve this problem for them.

Using the QuickGraph library I provide a very simple command line program that can be used to quickly solve this problem.

Usage:
=====

Input file: use an input file with an format like the following:

    file1   > file2
    file3   > file4
    
Where `file1 > file2` means that file1 depends from file2.

The output of the program will be all items sorted by dependency.