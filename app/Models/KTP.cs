namespace app.Models
{
  public class KTP
  {
    public string EKTP_STATUS { get; set; }
    public string DUSUN { get; set; }
    public string NAMA_LGKP { get; set; }
    public string STAT_HBKEL { get; set; }
    public string AGAMA { get; set; }
    public string EKTP_CREATED { get; set; }
    public string JENIS_PKRJN { get; set; }
    public string PDDK_AKH { get; set; }
    public string TMPT_LHR { get; set; }
    public string STATUS_KAWIN { get; set; }
    public string GOL_DARAH { get; set; }
    public string LAST_UPDATED { get; set; }
    public string JENIS_KLMIN { get; set; }
    public long? NO_KK { get; set; }
    public long NIK { get; set; }
    public string KAB_NAME { get; set; }
    public string KEC_NAME { get; set; }
    public int? NO_RW { get; set; }
    public int? NO_KEL { get; set; }
    public int? NO_RT { get; set; }
    public int? KODE_POS { get; set; }
    public int? NO_KEC { get; set; }
    public string ALAMAT { get; set; }
    public int? NO_PROP { get; set; }
    public string NAMA_LGKP_IBU { get; set; }
    public string PROP_NAME { get; set; }
    public int? NO_KAB { get; set; }
    public string TGL_LHR { get; set; }
    public string KEL_NAME { get; set; }
  }

  public class Response
  {
    public string RESPON { get; set; }
    public Response() { }
    public Response(string message)
    {
      RESPON = message;
    }
  }
}
