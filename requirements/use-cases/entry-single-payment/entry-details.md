# Summary

- **Title:** Single Payment Entry Details
- **Description:** The system gives details related to an entry
- **Pre-condition:** Entry must exists
- **Pos-condition:** Single Payment Entry's details are shown

# Flow

### Normal Flow

1. User initiates the single payment entry details process.
2. System provides informations about this entry, such as:
    - ID
    - ID of Category
    - Date
    - Last change Date
    - Money added or removed
    - Comment
    - Type
    - Status
    - List of tags

### Alternative Flow (2) [Entry is deleted]

2.1. System also provides more information, such as:
    - Date of deletion
    - How many days until its permanently removed

### Alternative Flow (2) [Category is Sub Category]

2.1. System also provides more information, such as:
    - ID of parent category
