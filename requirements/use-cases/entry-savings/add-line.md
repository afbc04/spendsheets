# Summary

- **Title:** Add Line of Entry Saving
- **Description:** Administrators can add line in entry saving
- **Pre-condition:** User must be Administrator & Entry can not be DONE or DRAFT
- **Pos-condition:** Entry has a new line

# Flow

### Normal Flow

1. User initiates the add line in saving entry process.
2. User provides:
    - Money added or removed
    - Date _(Optional)_
    - Comment _(Optional)_
3. System validates the information provided
4. System fills the missing information, such as:
    - If no date, date is the current date
5. System saves the new line of entry, providing the ID to the user
6. System updates the last change date of entry

### Alternative Flow (5) [Entry had 0 movements & entry not paid]

5.1. System updates the entry' status as PARTIAL
5.2. _Back to step 6_

### Alternative Flow (5) [Entry is paid]

5.1. System updates the entry' status as COMPLETED
5.2. _Back to step 6_

### Exception (3) [Information is invalid]

4. System informs to user that information provided is invalid
