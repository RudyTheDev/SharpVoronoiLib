# Supercluster.KDTree
This is a [KD-Tree](https://en.wikipedia.org/wiki/K-d_tree) written completely in C#.  This project originally 
started as a fork of the KD-Tree Written by [CodeandCats](https://github.com/codeandcats), however, the 
structure and intention of this project has changed drastically from its origin. 

## About the Project

This is a KD-Tree that is optimized for machine learning applications, **however, it can used for less intensive purposes as well**. (In fact, I am writing this for my machine learning library [Supercluster](https://github.com/eric-regina/Supercluster)) In machine learning data-sets
 are often built, re-built, and built again. Also, in machine learning, algorithms need to be **fast** 
for look ups but it is more acceptable to be slow for construction.
Thus the tree bas been designed with this philosophy in mind. General characteristics are:

* **The tree is extremely fast for search.** 
    * For a 10,000 3-nearest-neighbor searches on a 1,000,000 node 2-Dimensional tree using floats is about 7.5 times than the KD-Tree 
by [CodeandCats](https://github.com/codeandcats) (number based off of a 1,000,000 sample
independent T-test for mean comparisons, equal variance assumed). 
    * The nearest-neighbor list is a custom data structure (called a BoundedPriorityList) that remains sorted and has O(log n) insert, but it is often much faster than O(log n) as an item is ignored if it is larger than the lists current max-element.
    * Utilizes .NET's new [aggressive inlining](https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.methodimploptions.aspx) optimization *where appropriate*.
    * The KD-Tree is implemented as an array. Index arithmetic is used to traverse nodes. This is faster (only slightly, but a statistically significant difference)
than traversing node objects. This also leads to less memory usage.
    * The tree is built in the standard-way using an exact median finding algorithm. 
This is slower than the [quickselect](https://en.wikipedia.org/wiki/Quickselect) or [median-of-medians](https://en.wikipedia.org/wiki/Median_of_medians) algorithm but is more 
likely to create a balanced tree. This allows for search time to be as close to O(log n) as possible.

* **There is no delete method.** If you want to change the tree, rebuild it. Many KD-Tree implementations simply
rebuild the tree to "balance" the tree after deletion. This is because balancing a KD-Tree is much more 
complicated than AVL or Red-Black trees. There do exist adaptive KD-Trees which auto-balance, look it up if you need one.
* **There is no node object used in the KDTree class.** but there is a **NodeNavigator** class which allows you to traverse the tree (or any array) using familiar, left, right, parent properties of a node. 
* The tree is generic. Only [`IComparable<T>`](https://msdn.microsoft.com/en-us/library/4d7sx9hd.aspx) is required.
* The tree requires a metric (a distance measure function) `Func`. KD-Trees are spatial data-structures and one only needs a metric function to implicitly define the [metric space](https://en.wikipedia.org/wiki/Metric_space) in which the KD-Tree lives.
* **The code is unit tested and well documented.** Style-cop, unit-test, wiki tutorials and MSDN style docs. It's all here.

**Documentation and Tutorial**:
*  MSDN Style Documentation: http://eric-regina.github.io/Supercluster.KDTree
*  Wiki and Tutorials: https://github.com/eric-regina/Supercluster.KDTree/wiki
*  Nuget Package: `Install-Package Supercluster.KDTree`

#### Special Thanks

* Thanks to [CodeandCats](https://github.com/codeandcats) for the original implementation that this was based off. I had fun ~~tearing apart~~ reading your code. ;)
* Thanks to [Prof. Hanan Samet](http://www.cs.umd.edu/~hjs/) for writing an amazing book on spatial and metric data structures. The book provided much insight and knowledge.
* Thanks to [César Souza](https://github.com/cesarsouza) for your work on machine learning for .NET. It has inspired me to try and do better!
* Also a small thanks to [BlueRaja](https://github.com/BlueRaja). While I didn't use any of your code your [high speed priority queue](https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp)
   inspired me to write my own custom data structure for the nearest-neighbor list which turned out to be way faster than any "off the shelf" solution.
