# Summary

- **Title:** Delete Entry Saving
- **Description:** Administrators can delete saving entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Saving Entry is deleted

# Flow

### Normal Flow

1. User initiates the delete saving entry process.
2. User selects the entry
3. System removes the entry, changing:
    - Status to DELETED
    - Updating date of last change
    - Saving current date as deletion date

### Alternative Flow (3) [Saving Entry has movements related to entry]

3.1. System cancels the entry, changing:
    - Status to CANCELLED
    - Updating date of last change
    - Saving current date as cancellation date

### Alternative Flow (3) [Entry is in DRAFT mode]

3.1. System removes the entry completly