# Summary

- **Title:** Remove Line of Entry
- **Description:** Administrators can remove line in entries
- **Pre-condition:** User must be Administrator & entry must exist
- **Pos-condition:** Entry has a line removed

# Flow

### Normal Flow

1. User initiates the remove line in entry process.
2. User selects the entry
3. User selects the line
4. System validates the information provided
5. System deletes the line of entry
6. System updates the last change date of entry

### Alternative Flow (5) [Entry now has 0 movements]

5.1. System updates the entry's status as PENDING
5.2. _Back to step 6_

### Alternative Flow (5) [Entry now isnt paid but has movements]

5.1. System updates the entry's status as ONGOING
5.2. _Back to step 6_

### Exception (2) [Entry is Transation or Saving]

2.1. System informs to user this entry can not have lines removed

### Exception (4) [Information is invalid]

4.1. System informs to user that information provided is invalid
