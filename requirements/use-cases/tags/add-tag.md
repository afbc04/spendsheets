# Summary

- **Title:** Add Tag
- **Description:** Administrators can create tags
- **Pre-condition:** User must be Administrator
- **Pos-condition:** System has a new tag

# Flow

### Normal Flow

1. User initiates the add tag process.
2. User provides:
    - Name
    - Description _(Optional)_
3. System validates the information provided
4. System saves the new tag, providing the ID to the user 

### Exception (3) [Information is invalid]

4. System informs to user that information provided is invalid
