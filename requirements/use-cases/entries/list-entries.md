# Summary

- **Title:** List entries
- **Description:** System provides list of entries
- **Pre-condition:** User could read entries
- **Pos-condition:** Entries are listed

# Flow

### Normal Flow

1. User initiates the list entries process.
2. System shows entries, showing information such as:
    - ID
    - ID of Category
    - Type:
        - Transation:
            - Money added or removed
        - Loan:
            - Money needed to be paid
        - Due Payment:
            - Money needed to be paid
        - Saving:
            - Money planned to be spent
    - Begin Date
    - Status

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

### Alternative Flow (2) [Draft Entries]

2.1. System show only draft entries

### Alternative Flow (2) [Deleted Entries]

2.1. System show only deleted entries, showing more informations such as:
    - Deletion Date

### Alternative Flow (2) [Loan Entries]

2.1. System show only loan entries, showing more informations such as:
    - Money remaining to be paid
    - How many days until due date

### Alternative Flow (2) [Due Payment Entries]

2.1. System show only due payment entries, showing more informations such as:
    - Money remaining to be paid
    - How many days until due date

### Alternative Flow (2) [Saving Entries]

2.1. System show only saving entries, showing more informations such as:
    - Money planned to be spent