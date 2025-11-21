# Summary

- **Title:** Loan Entry Details
- **Description:** The system gives details related to an entry
- **Pre-condition:** Entry must exists
- **Pos-condition:** Loan Entry's details are shown

# Flow

### Normal Flow

1. User initiates the loan entry details process.
2. System provides informations about this entry, such as:
    - ID
    - ID of Category
    - Date
    - Last change Date
    - Borrow money added or removed
    - Comment
    - Type
    - Status
    - List of tags
    - List of movements, indicating:
        - Money added or removed
        - ID of line
        - Date
        - Comment
        - Is annulled?
    - Money left until its paid
    - Money paid

### Alternative Flow (2) [Entry is deleted/cancelled]

2.1. System also provides more information, such as:
    - Date of deletion/cancellation
    - How many days until its permanently removed (in case of deletion)