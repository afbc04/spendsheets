# Summary

- **Title:** Delete Entry Due Payment
- **Description:** Administrators can delete due payment entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Due Payment Entry is deleted

# Flow

### Normal Flow

1. User initiates the delete due payment entry process.
2. User selects the entry
3. System removes the entry, changing:
    - Status to DELETED
    - Updating date of last change
    - Saving current date as deletion date

### Alternative Flow (3) [Due Payment Entry has movements related to entry]

3.1. System cancels the entry, changing:
    - Status to CANCELLED
    - Updating date of last change
    - Saving current date as cancellation date

### Alternative Flow (3) [Due Payment Entry is from a monthly service category]

3.1. System cancels the entry, changing:
    - Status to IGNORED
    - Updating date of last change
    - Saving current date as ignoration date

### Alternative Flow (3) [Entry is in DRAFT mode]

3.1. System removes the entry completly