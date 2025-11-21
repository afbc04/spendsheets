# Summary

- **Title:** Edit Category
- **Description:** Administrators can edit existing categories
- **Pre-condition:** User must be Administrator & category must exists
- **Pos-condition:** Category's information is updated

# Flow

### Normal Flow

1. User initiates the edit category process.
2. User selects the category
3. User provides the new information, such as:
    - Name of category
    - Description of category
4. System validates the information provided
5. System updates the category

### Alternative Flow (3) [Type is Monthly Service]

3.1. User provides more information, such as:
    - Monthly amount _(Optional)_
    - Is active? _(Optional)_
3.2. _Back to step 4_

### Exception (4) [Information is invalid]

5. System informs to user that information provided is invalid
