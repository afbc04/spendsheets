# Summary

- **Title:** Due Payment Entry Details
- **Description:** The system gives details related to an entry
- **Pre-condition:** Entry must exists
- **Pos-condition:** Due Payment Entry's details are shown

# Flow

### Normal Flow

1. User initiates the loan entry details process.
2. System provides informations about this entry, such as:
    - ID
    - ID of Category
    - Begin Date
    - Scheduled Due Date
    - Real Due Date
    - Last change Date
    - Money to be paid
    - Comment
    - Type
    - Status _(SCHEDULED if begin date is later)_
    - List of tags
    - List of movements, indicating:
        - Money added or removed
        - ID of line
        - Date
        - Comment
        - Is annulled?
    - Money left until its paid
    - Money paid

### Alternative Flow (2) [Entry is deleted/cancelled/ignored]

2.1. System also provides more information, such as:
    - Date of deletion/cancellation/ignoration
    - How many days until its permanently removed (in case of deletion)