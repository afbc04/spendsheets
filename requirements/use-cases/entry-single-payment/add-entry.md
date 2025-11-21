# Summary

- **Title:** Add Entry Single Payment
- **Description:** Administrators can create entry single payment
- **Pre-condition:** User must be Administrator
- **Pos-condition:** System has a new entry

# Flow

### Normal Flow

1. User initiates the add single payment entry process.
2. User provides:
    - Category _(Optional)_
    - Money added or removed
    - Date _(Optional)_
    - List of tags _(Optional)_
    - Comment _(Optional)_
3. System validates the information provided
4. System fills the missing information, such as:
    - If no date, date is the current date
    - Status is DRAFT
    - Date of last change is the current date
    - Date of Creation of entry is the current date
    - Type is Single Payment
5. System saves the new entry, providing the ID to the user 

### Alternative Flow (4) [User marked entry as finished]

4.1. System fills the missing information, such as:
    - If no date, date is the current date
    - Status is DONE
    - Date of last change is the current date
    - Date of Creation & Finish of entry is the current date
    - Type is Single Payment
4.2. _Back to step 5_

### Exception (3) [Information is invalid]

4. System informs to user that information provided is invalid
