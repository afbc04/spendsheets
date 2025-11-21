# Summary

- **Title:** Delete Line of Entry Saving
- **Description:** Administrators can delete line of saving entries
- **Pre-condition:** User must be Administrator, line and entry must exists & Entry can not be DONE
- **Pos-condition:** Saving Entry has less movements

# Flow

### Normal Flow

1. User initiates the delete line of saving entry process.
2. User selects the entry
3. User selects the line of entry
4. System removes the line annullating it
5. System updates the last change date of entry

### Alternative Flow (4) [Entry has now 0 movements]

4.1. System updates the entry' status as PENDING
4.2. _Back to step 5_

### Alternative Flow (4) [Entry has movements but its not paid]

4.1. System updates the entry' status as PARTIAL
4.2. _Back to step 5_