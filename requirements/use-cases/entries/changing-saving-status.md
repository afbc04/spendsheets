# Summary

- **Title:** Changing Saving Entry's Status
- **Description:** Administrators can change saving entries' status
- **Pre-condition:** User must be Administrator & saving entry must exists
- **Pos-condition:** Saving Entry is updated

# Flow

### Normal Flow

1. User initiates the saving entry's status process.
2. User selects the entry
3. User indicates the entry's status should be stalled or accomplished
4. System update last change date of this entry

### Exception (4) [Entry is not on ONGOING status]

4.1. System informs this entry can not be updated to these status
