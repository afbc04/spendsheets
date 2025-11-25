# Summary

- **Title:** List entries
- **Description:** System provides list of entries
- **Pre-condition:** -
- **Pos-condition:** Entries are shown

# Flow

### Normal Flow

1. User initiates the list entries process.
2. System shows entries, showing information such as:
    - ID
    - ID of Category
    - Type:
        - Single Payment:
            - Money added or removed
        - Loan:
            - Money needed to be paid
        - Due Payment:
            - Money needed to be paid
            - Days left
        - Saving:
            - Money total
            - Money collected
    - Begin Date
    - Status _(except DELETED)_

### Alternative Flow (2) [Filtered list]

2.1. System could filter entries, with those criteria:
    - Category
    - Tags
    - Type
    - Status
    - Period of Time
    - Money added or removed

### Alternative Flow (2) [Ordered list]

2.1. System could order entries, with those criteria:
    - Begin Date
    - Due Date
    - Money added
    - Money removed
