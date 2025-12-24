# Summary

- **Title:** Edit Line of Entry
- **Description:** Administrators can edit lines in entries
- **Pre-condition:** User must be Administrator & entry must exist
- **Pos-condition:** Entry has a line changed

# Flow

### Normal Flow

1. User initiates the edit line in entry process.
2. User selects the entry
3. User selects the line
4. User provides new information, such as:
    - Money added or removed
    - Date
    - Comment
5. System validates the information provided
6. System updates the line of entry
7. System updates the last change date of entry

### Exception (2) [Entry is Transation or Saving]

2.1. System informs to user this entry can not edit lines

### Exception (5) [Information is invalid]

5.1. System informs to user that information provided is invalid
