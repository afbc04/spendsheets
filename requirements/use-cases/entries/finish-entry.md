# Summary

- **Title:** Finish Entry
- **Description:** Administrators can finish entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Entry is finished

# Flow

### Normal Flow

1. User initiates the finish entry process.
2. User selects the entry
3. System updates entry's information, such as:
    - Update last change date
    - Use current date as finish date
    - Update status as DONE

### Exception (3) [Entry is not on ONGOING status]

3.1. System informs this entry can not be finished
