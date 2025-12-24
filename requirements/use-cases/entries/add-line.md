# Summary

- **Title:** Add Line of Entry
- **Description:** Administrators can add line in entries
- **Pre-condition:** User must be Administrator & entry must exist
- **Pos-condition:** Entry has a new line

# Flow

### Normal Flow

1. User initiates the add line in entry process.
2. User selects the entry
3. User provides:
    - Money added or removed
    - Date _(Optional)_
    - Comment _(Optional)_
4. System validates the information provided
5. System fills the missing information, such as:
    - If no date, date is the current date
6. System saves the new line of entry
7. System updates the last change date of entry

### Alternative Flow (6) [Entry had 0 movements & entry not paid]

6.1. System updates the entry's status as ONGOING
6.2. _Back to step 7_

### Alternative Flow (6) [Entry is paid]

6.1. System updates the entry's status as COMPLETED
6.2. _Back to step 7_

### Exception (2) [Entry is Transation or Saving]

2.1. System informs to user this entry can not have new lines

### Exception (4) [Information is invalid]

4.1. System informs to user that information provided is invalid
