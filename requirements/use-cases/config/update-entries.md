# Summary

- **Title:** System updating entries
- **Description:** System updating entries when system boots up
- **Pre-condition:** Config must exists
- **Pos-condition:** Entries are updating

# Flow

### Normal Flow

1. System is initiated, considering current date and last open date
2. If entries that are in trash should be auto removed and has more than life days, system should remove them from database
3. If month changes, creates due payments about active monthly services
