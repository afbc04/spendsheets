# Summary

- **Title:** Delete Entry
- **Description:** Administrators can delete entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Entry is deleted

# Flow

### Normal Flow

1. User initiates the delete entry process.
2. User selects the entry
3. User informs if he wants the entry to be permanently removed
4. System validates if entry can be deleted
5. System removes the entry, changing:
    - Status to DELETED
    - Updating date of last change
    - Saving current date as deletion date

### Alternative Flow (4) [Entry was system generated]

4.1. System cancels the entry, changing:
    - Status to IGNORED
    - Updating date of last change
    - Saving current date as ignoration date

### Alternative Flow (4) [Entry has movements]

4.1. System cancels the entry, changing:
    - Status to CANCELLED
    - Updating date of last change
    - Saving current date as cancellation date

### Alternative Flow (4) [Entry is in DRAFT mode or User intends to remove entry permanently]

4.1. System removes the entry completly

### Exception (3) [Entry is already deleted/cancelled/ignored]

3.1. System informs this entry can not be deleted