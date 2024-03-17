
using System;

public class Category
{
    public string CategoryName { get; }
    public string Description { get; }

    public Category(string categoryName, string description)
    {
        CategoryName = categoryName;
        Description = description;
    }
}
