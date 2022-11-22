using System.Configuration;
using System.Drawing;
using System.Text;


namespace ClassLibrary
{
    public class Globals
    {
        /// <summary>
        /// Initialized at start-up
        /// </summary>
        public static string IQDIS_API_Url = null;

        /// <summary>
        /// Initialized at start-up
        /// </summary>
        //public static IQ_User CurrentUser = null;

        /// <summary>
        /// IMPORTANT!!! DO NOT CHANGE!!!!!
        /// </summary>
        public static string EncryptionKey = "!iqdis@2017_!";
        //public static string FolderCache = Path.GetDirectoryName(Application.ExecutablePath) + "\\Cache";
        public static Font GlobalFont = new Font(new FontFamily("Arial"), 10);
        public static string TempFilePath = "Temp";
        public const string DateFormat = "MM-dd-yyyy";
        public const string TimeFormat = "HH:mm";
        public const string DateTimeFormat = "MM-dd-yyyy HH:mm";
        public const string CellTypeCurrency = "Currency";
        //public static string LogPath = Utils.GetString(ConfigurationManager.AppSettings["LogPath"]);
        //public static string LogErrorPath = Utils.GetString(ConfigurationManager.AppSettings["LogErrorPath"]);
        //public static bool Debug = Utils.GetString(ConfigurationManager.AppSettings["Debug"]).ToLower().Equals("true");

        public static string[] ManhattanCodes = new string[]{
            "00083", "83", "10001", "10002", "10003", "10004", "10005", "10006", "10007", "10009", "10010",
            "10011", "10012", "10013", "10014", "10016", "10017", "10018", "10019", "10020", "10021", "10022",
            "10023", "10024", "10025", "10028","10036", "10038", "10038", "10065", "10069", "10075", "10128", "10280"
        };

        public static string CurrentCompanyInfoString = string.Empty;
        public static string GOOGLE_API_KEY = "";

        public static string HereMaps_ApiID = "";
        public static string HereMaps_ApiCode = "";
        public static string HereMaps_ApiKey = "";

        public static bool UseTrafficModel = false;

        public enum GeocodingEngineType
        {
            INVALID = -1,
            GOOGLE = 0,
            LOCATION_IQ = 1,
            HERE_MAPS = 2
        }

        public static List<Color> AlternateRowAvailableColors
        {
            get
            {
                return new List<Color>() {
            Color.White,
            Color.AliceBlue,
            Color.WhiteSmoke,
            Color.Gainsboro,
            Color.LightGray,
            Color.LightBlue,
            Color.LightSalmon,
            Color.LightPink };
            }
        }

        public enum CompletedByState
        {
            UBER = 0,
            LYFT = 1,
            VIA = 2,
            GET = 3,
            EPIC = 4,
            OTHER = 5,
            BASE = 6
        }
    }

    public enum GlobalSettings
    {
        TLC_REPORT_DEFAULT_FILE_TYPE,
        TLC_REPORT_DEFAULT_SCHEMA_TYPE
    }

    public enum ObjectTypes
    {
        Driver = 0,
        Client = 1,
        Insurance = 2,
        Facility = 3,
        Vehicle = 4,
        Medallion = 5,
        MedallionOwner = 6
    }

    public enum ServiceCodeAutoInsertTypes
    {
        Quantity_Always_One = 0,
        Quantity_Equals_Mileage = 1,
        Manhattan_Extra_Charge = 5
    }

    public enum RoundByType
    {
        NONE = 0,
        ROUND_UP = 1,
        ROUND_DOWN = 2,
        ROUND = 3
    }

    public enum Carriers
    {
        LOGISTICARE = 2,
        NMN = 3,
        MTA = 4,
        MAS = 5,
        SENTRY = 6,
        MTM = 7,
        ELDERSERVE = 8,
        ICS = 9,
        MEDICAID = 10,
        LIMOSYS = 11,
        CTS = 12,
        FIDELIS = 13,
        JCC = 14,
        MTA_VAN = 15,
        BASE = 16,
        COPPER = 17,
        MODIVCARE = 18,
        R2MD = 19,
        ACC2CARE = 20,
        PROTRANS = 21
    }

    public enum StandingOrder_ProcessResult
    {
        NotProcessed = 0,
        OK = 1,
        NotActive = 2,
        NotValidDay = 3,
        NotInActivePeriod = 4,
        InHoldPeriod = 5,
        TripForClientExists = 6,
        AlreadyProcessed = 7

    }

    public enum TransportationMode
    {
        ambulette = 1,
        livery = 2,
        ambuletteWC = 3,
        Stretcher = 4

    }

    public enum GridFontSize
    {
        Small = 8,
        Medium = 10,
        Large = 12
    }

    public enum NotificationImportance
    {
        None = 0,
        Simple = 1,
        Important = 2
    }

    public enum GridFontFamily
    {
        Arial,
        Arial_Narrow,
        Calibri,
        Calibri_Light,
        Consolas,
        Courier_New,
        Segoe_UI,
        Segoe_UI_Black,
        Microsoft_Sans_Serif
    }

    public enum TripState
    {
        NONE = 0,
        CREATED = 10,
        CUST_CONFIRMED = 20,
        CUST_CONFIRMED_NO = 21,
        CUST_CONFIRMED_LM = 22,
        CUST_CONFIRMED_WN = 23,
        ASSIGNED = 30,
        CONFIRMED = 40,
        STARTED = 50,
        AUTO_ARRIVED = 55,
        ARRIVED = 60,
        CALL_OUT = 65,
        PICKED = 70,
        SIGNED = 80,
        AUTO_DROPPED = 85,
        DROPPED = 90,
        CANCEL_REQUEST = 95,
        CANCELLED_AT_DOOR = 97,
        CANCELLED = 100,
        PAUSED = 200,
        //PAID = 300,
    }

    public enum DispatchState
    {
        NONE = 0,
        UNSUCCESSFUL = 1,
        SUCCESSFUL = 2,
        IN_PROGRESS = 3
    }

    public enum PaymentType
    {
        Manual = 0,
        NMN_Excel = 1,
        Medicaid_Tar = 2,
        Auto_Generated = 3,
        LGTC_Csv = 4,
        ELDERSERVE_Edi = 5,
        SENTRY_Excel = 6,
        ICS_835 = 7,
        FIDELIS_835 = 8,
        SENTRY_CSV = 9,
        MTM_EXCEL = 10,
        CTG_EXCEL = 11,
        LIMOSYS_EXCEL = 12
    }

    public enum EntityHistoryType
    {
        Created = 1,
        Modified = 2,
        Deleted = 3
    }

    //public enum TripServiceCodeHistoryType
    //{
    //    AddedToPayment = 1,
    //    RemovedFromPayment = 2,
    //    AddedToInvoice = 3,
    //    RemovedFromInvoice = 4
    //}

    public enum PartnerType
    {
        Unknown = 0,
        Client = 1,
        Provider = 2,
        Insurance = 3
    }

    public enum TransactionStatus
    {
        ACTIVE = 0,
        INACTIVE = 1
    }

    public enum PayRateType
    {
        HOURLY = 1,
        SALARY = 2
    }

    public enum StatementItemType
    {
        Invoice = 0,
        Payment = 1,
        BalanceForward = 3
    }

    public enum MessageType
    {
        NONE = 0,
        TRIP_RELOAD = 1,
        FORCE_LOGOUT = 2,
        FORCE_LOGOUT_INACTIVE = 3,
        SOS = 10,
        NORMAL = 20,
        TRIP_MSG = 30,
        TRIP_CANCEL = 40,
        WRONG_ARRIVE = 45,
        WRONG_DROP_OFF = 50,
        WRONG_PICK_UP = 60,
        NO_CARNO = 70,
        CARNO_ASSIGNED = 71,
        CCENTER_NORMAL = 100,
        CCENTER_FORCE_LOG_OUT = 110,
        CTG_REPORT_ERROR = 120,
        CTG_DRIVER_INFO_ERROR = 121,
    }

    public enum PermissionEnum
    {
        CAN_VIEW_EMPLOYEE_MENU = 1,
        CAN_CREATE_DRIVER_REPORT = 2,
        CAN_CREATE_PAYROLL = 3,
        CAN_CONFIGURE_USERS = 4,
        CAN_VIEW_BILLING_MENU = 5,
        CAN_VIEW_PAYMENT_MENU = 6,
        CAN_VIEW_INVOICE_MENU = 7,
        CAN_VIEW_DOWNLOAD_CREDENTIALS = 8,
        CAN_IMPORT_DATA = 9,
        CAN_VIEW_BACKUP = 10,
        CAN_VIEW_FILES = 11,
        CAN_VIEW_REPORTS = 12,
        CAN_VIEW_COMPANY_INFO = 13,
        CAN_DELETE_DRIVER_TIMESHEET = 14
    }

    public enum Role
    {
        USER = 1,
        DISPATCHER = 2,
        ADMIN = 3,
        BILLER = 4
    }

    public enum BillState
    {
        NONE = 0,
        UNBILLED = 1,
        ATTESTATED = 2,
        BILLED_MEDICAID = 3,
        BILLED_INSURANCE = 4,
        PAID_PARTIALLY = 5,
        PAID = 6,
        DENIED = 7,
        PENDING = 8,
        INVOICE = 9,
        BILLING_FORM = 10,
        BILLED_ONE_WAY = 11,
        REVERSAL_OF_PAYMENT = 12,
        IGNORED = 13,
        ROSTER_APPLIED = 14,
        UNPAID = 15
    }

    public enum DriverType
    {
        HELPER = 0,
        DRIVER = 1,
        ALL = 2,
        COPPER = 3,
        UBER = 4,
        LYFT = 5
    }

    public enum AccountState
    {
        Validated = 0,
        Pending = 1,
        AccountDetails = 2,
        DMV = 4,
        TLC = 8,
        SSN = 16,
        Payment = 32,
        Contracts = 64,
        DMVCheck = 128,
        COVIDSubmitted = 256,
        COVIDChecked = 512
    }

}
