### **TrimUrlExtraSlashes**

The **TrimUrlExtraSlashes** project provides a utility function to clean up URLs by removing unnecessary slashes (`/`). This is particularly useful when dealing with dynamic URL generation or integration between systems where URLs might accumulate redundant slashes, potentially causing errors or inconsistencies.

#### Example

```csharp
string rawUrl = "https://example.com//path//to///resource";
string cleanedUrl = TrimUrlExtraSlashes(rawUrl);

// Output: "https://example.com/path/to/resource"
```

#### Features
- Trims multiple consecutive slashes in a URL, leaving only single slashes.
- Maintains the correct structure of URLs, including protocols (`http://`, `https://`).
- Simple to use and easily integrated into any C# project.

### Usage

Clone the repository and include the relevant project or function in your codebase to use these utilities. Contributions and suggestions for new utilities are welcome!

---

## How to Contribute

We’re always looking to improve and expand this collection! If you have useful functions that you think would fit, feel free to open a pull request or submit issues for improvements.

---

## License

This repository is licensed under the MIT License. Feel free to use and modify the code as per your project requirements.
