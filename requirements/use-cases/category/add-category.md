# Summary

- **Title:** Add Category
- **Description:** Administrators can create categories
- **Pre-condition:** User must be Administrator
- **Pos-condition:** System has a new category

# Flow

### Normal Flow

1. User initiates the add category process.
2. User provides:
    - Name
    - Description _(Optional)_
    - Type
3. System validates the information provided
4. System determines the ID and Creation Date of new category
5. System assumes category does not has parent
6. System saves the new category, providing the ID to the user 

### Alternative Flow (2) [Type is Monthly Service]

2.1. User provides more information, such as:
    - Monthly amount _(Optional)_
    - Is active? _(Optional)_
2.2. System saves the category as active monthly service
2.3. _Back to step 3_

### Alternative Flow (2) [Category is subcategory]

2.1. User provides more information, such as:
    - ID of parent category
2.2. _Back to step 3_

### Exception (2.1.) [Parent Category cannot be a parent category]

2.1.1. System informs to user that parent category is not invalid, which reasons can be:
    - Is a sub category
    - Is a monthly service category

### Exception (3) [Information is invalid]

4. System informs to user that information provided is invalid
