# Summary

- **Title:** Remove Category
- **Description:** Administrators can remove categories
- **Pre-condition:** User must be Administrator & category must exists
- **Pos-condition:** Category is removed

# Flow

### Normal Flow

1. User initiates the delete category process.
2. User selects the category
3. System removes the category
4. Every entry that has this category will have no category

### Exception (3) [Category is parent category of at least 1 sub category]

3.1. System informs action could not be performed because there is at least 1 sub category related to the current category

