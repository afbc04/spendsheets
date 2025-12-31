public class AccessToken {

    public bool is_writer {private set; get;}
    public bool is_valid {private set; get;}

    public AccessToken(bool is_writer, bool is_valid) {

        this.is_writer = is_writer;
        this.is_valid = is_valid;

    }

}