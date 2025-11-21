# Summary

- **Title:** Convert Saving Entry
- **Description:** Administrators can convert savings into single payment entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Entry is converted

# Flow

### Normal Flow

1. User initiates the convert saving entry process.
2. User selects the entry
3. System converts entry into a single payment entry, filling those fields:
    - ID the same
    - ID of category is same or can be changed
    - Type is Single Payment
    - Date of last change & creation is the current date
    - Tags are the same
    - Indicates single payment came from saving entry
    - Begin Date is the current date
    - Status is DRAFT or DONE _(Depending of user's will)_
