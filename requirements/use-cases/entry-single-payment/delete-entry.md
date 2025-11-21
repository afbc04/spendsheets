# Summary

- **Title:** Delete Entry Single Payment
- **Description:** Administrators can delete single payment entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Single Payment Entry is deleted

# Flow

### Normal Flow

1. User initiates the delete single payment entry process.
2. User selects the entry
3. System removes the entry, changing:
    - Status to DELETED
    - Updating date of last change
    - Saving current date as deletion date

### Alternative Flow (3) [Entry is in DRAFT mode]

3.1. System removes the entry completly