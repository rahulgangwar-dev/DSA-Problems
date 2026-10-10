# Problems — Topic-wise Order

Isi order mein practice/revise karo. Har folder ek pattern hai.

| # | Folder | Pattern | Count |
|---|--------|---------|-------|
| 1 | `01_ArrayBasics` | In-place array operations, two pointers | 8 |
| 2 | `02_HashingAndCounting` | HashMap / HashSet | 7 |
| 3 | `03_PrefixSuffixKadane` | Prefix sum, Kadane's | 4 |
| 4 | `04_SlidingWindowTwoPointer` | Sliding window, two pointer | 3 |
| 5 | `05_BinarySearchBasic` | Binary search (basic) | 9 |
| 6 | `06_BinarySearchOnAnswer` | Binary search on answer | 4 |
| 7 | `07_StackAndMonotonicStack` | Stack, monotonic stack | 7 |
| 8 | `08_Queue` | Queue, circular queue | 3 |
| 9 | `09_GreedyAndDaily` | Greedy, simulation, misc daily problems | 6 |

**Total: 51 problems**

## ⚠️ Issues found while reorganizing (unfixed, flagged only)

1. **`02_HashingAndCounting/ContainsDuplicate_Attempt1_MISLABELED.cs`** and
   **`ContainsDuplicate_Attempt2_MISLABELED.cs`** — in the old `Array2` folder these
   were named `ContainsDuplicate.cs` and `ValidPalindrome.cs`, but **both files
   actually contain the same Contains Duplicate logic** (class names were swapped
   too: the file named `ContainsDuplicate.cs` had `class ValidPalindrome`, and
   vice versa). **Valid Palindrome was never actually solved** — you'll need to
   write it fresh.

2. **`08_Queue/MyCircularQueue_CONTENT-MISMATCH-DO-NOT-COMPILE.cs`** — this file
   is named `MyCircularQueue.cs` but its actual content is the **Asteroid
   Collision** solution (a duplicate of `07_StackAndMonotonicStack/AsteroidCollisions.cs`,
   declared as `partial class`). Your real Circular Queue implementation isn't in
   this project at all — it exists in your earlier `DSA.zip` as
   `Queue/Design Circular Queue.cs`. I've **excluded this file from the build**
   (left as `<None>` in the `.csproj`) because compiling it alongside
   `AsteroidCollisions.cs` would throw a duplicate-member error (both define
   `AsteroidCollision()` in the same `partial class` in namespace `DSA.Stack`).
   Copy your real implementation in from the old project, or rewrite it, and
   rename this file.

3. **`02_HashingAndCounting/LongestConsecutiveSequence.cs`** — the code itself is
   correct, but its header comment ("Output: true") is stale/copy-pasted from a
   different problem. Not a functional bug, just a misleading comment.

## Not moved

- `Program.cs`, `Properties/AssemblyInfo.cs` — stay at project root.
- `counterGameProblem.cs` — stays at project root; it's unrelated sandbox code
  (references `Hl7.Fhir.*`), not a DSA problem, so I left it where it was rather
  than guessing where you'd want it.

## What changed structurally (no problem-solving logic was touched)

- Removed `Stack/Stack/` — an exact duplicate nested folder (same 7 files twice).
- Renamed a few files to disambiguate two different attempts at the same
  LeetCode problem (e.g. `3Sum_Attempt1_Brute.cs` vs `3Sum_Attempt2_Optimal.cs`).
- Updated `DSA.csproj` to actually reference these files. Previously only 6
  files (`BomberMan.cs`, `minimumBribes.cs`, `sumXorr.cs`, `Program.cs`,
  `AssemblyInfo.cs`, `counterGameProblem.cs`) were in the `<Compile>` list — all
  51 practice problems existed on disk but **were not part of the build** and
  wouldn't have shown in Solution Explorer. They're all included now (except
  the mismatched file above).
- `bin/`, `obj/`, `.vs/` were excluded from this zip — they're build caches
  (already in your `.gitignore`), Visual Studio regenerates them on first build.
