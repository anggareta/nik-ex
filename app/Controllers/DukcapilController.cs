using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using app.Models;

namespace app.Controllers
{
  [Produces("application/json")]
  [Route("api")]
  public class DukcapilController : ControllerBase
  {
    [HttpGet("nik/{nik}")]
    public JObject UserNIK(string nik)
    {
      List<KTP> satu = new List<KTP>();
      satu.Add(_ktp.Find(x => x.NIK.ToString() == nik));

      var json = "";
      if (satu[0] != null)
      {
        SipilInfo info = new SipilInfo { content = satu, lastPage = true, numberOfElements = 1, sort = null, totalElements = 1, firstPage = true, number = 0, size = 1 };
        json = JsonConvert.SerializeObject(info);
      }
      else
      {
        //List<Response> xyz = new List<Response> { new Response("Data Tidak Ditemukan") };
        EmptyInfo info = new EmptyInfo { content = new List<Response> { new Response("Data Tidak Ditemukan") }, lastPage = true, numberOfElements = 1, sort = null, totalElements = 1, firstPage = true, number = 0, size = 1 };
        json = JsonConvert.SerializeObject(info);
      }

      JObject obj = JObject.Parse(json);
      return obj;
    }

    [HttpPost("call_nik")]
    public JObject mockDukcapil([FromBody] PostRequest formData)
    {
      List<KTP> satu = new List<KTP>();
      satu.Add(_ktp.Find(x => x.NIK.ToString() == formData.NIK));

      var json = "";
      if (satu[0] != null)
      {
        SipilInfo info = new SipilInfo { content = satu, lastPage = true, numberOfElements = 1, sort = null, totalElements = 1, firstPage = true, number = 0, size = 1 };
        json = JsonConvert.SerializeObject(info);
      }
      else
      {
        //List<Response> xyz = new List<Response> { new Response("Data Tidak Ditemukan") };
        EmptyInfo info = new EmptyInfo { content = new List<Response> { new Response("Data Tidak Ditemukan") }, lastPage = true, numberOfElements = 1, sort = null, totalElements = 1, firstPage = true, number = 0, size = 1 };
        json = JsonConvert.SerializeObject(info);
      }

      JObject obj = JObject.Parse(json);
      return obj;
    }

    public class PostRequest
    {
      public string NIK { get; set; }
      public string ip_user { get; set; }
      public string user_id { get; set; }
      public string password { get; set; }
    }

    private List<KTP> _ktp = new List<KTP>
        {
            new KTP
            {
                EKTP_STATUS = null,
                DUSUN = null,
                NAMA_LGKP = "FENNY MARYAM, SE",
                STAT_HBKEL = "Kabogoh Aa",
                AGAMA = "ISLAM",
                EKTP_CREATED = null,
                JENIS_PKRJN = "KARYAWAN BUMN",
                PDDK_AKH = "DIPLOMA IV/STRATA I",
                TMPT_LHR = "BOGOR",
                STATUS_KAWIN = "KAWIN",
                GOL_DARAH = null,
                LAST_UPDATED = null,
                JENIS_KLMIN = "Perempuan",
                NO_KK = 3174011310111047,
                NIK = 3271064708820005,
                KAB_NAME = "KOTA ADM. JAKARTA SELATAN",
                KEC_NAME = "TEBET",
                NO_RW = 9,
                NO_KEL = 1001,
                NO_RT = 7,
                KODE_POS = null,
                NO_KEC = 1,
                ALAMAT = "JL TEBET TIMUR DALAM VIII W / 28",
                NO_PROP = 31,
                NAMA_LGKP_IBU = "KRISNAWATI",
                PROP_NAME = "DKI JAKARTA",
                NO_KAB = 74,
                TGL_LHR = "1982-08-07",
                KEL_NAME = "TEBET TIMUR"
            },

            new KTP
            {
                EKTP_STATUS = null,
                DUSUN = null,
                NAMA_LGKP = "VERAWATI",
                STAT_HBKEL = "KEPALA KELUARGA",
                AGAMA = "ISLAM",
                EKTP_CREATED = null,
                JENIS_PKRJN = "KARYAWAN SWASTA",
                PDDK_AKH = "DIPLOMA IV/STRATA I",
                TMPT_LHR = "SURAKARTA",
                STATUS_KAWIN = "KAWIN",
                GOL_DARAH = null,
                LAST_UPDATED = null,
                JENIS_KLMIN = "Perempuan",
                NO_KK = 3175091301090782,
                NIK = 3175094401780005,
                KAB_NAME = "KOTA ADM. JAKARTA TIMUR",
                KEC_NAME = "CIRACAS",
                NO_RW = 9,
                NO_KEL = 1003,
                NO_RT = 12,
                KODE_POS = null,
                NO_KEC = 9,
                ALAMAT = "JL.MELATI NO.41",
                NO_PROP = 31,
                NAMA_LGKP_IBU = "SUNDARI R",
                PROP_NAME = "DKI JAKARTA",
                NO_KAB = 75,
                TGL_LHR = "1978-01-04",
                KEL_NAME = "KELAPA DUA WETAN"
            },

            new KTP
            {
                EKTP_STATUS= null,
                DUSUN= null,
                NAMA_LGKP= "MONICA YASURA",
                STAT_HBKEL= "ANAK",
                AGAMA= "ISLAM",
                EKTP_CREATED= null,
                JENIS_PKRJN= "PELAJAR/MAHASISWA",
                PDDK_AKH= "SLTA/SEDERAJAT",
                TMPT_LHR= "JAKARTA",
                STATUS_KAWIN= "BELUM KAWIN",
                GOL_DARAH= null,
                LAST_UPDATED= null,
                JENIS_KLMIN= "Perempuan",
                NO_KK= 3275052307064936,
                NIK= 3275056305940005,
                KAB_NAME= "KOTA BEKASI",
                KEC_NAME= "RAWALUMBU",
                NO_RW= 8,
                NO_KEL= 1003,
                NO_RT= 2,
                KODE_POS= 17114,
                NO_KEC= 5,
                ALAMAT= "JL PANGANDARAN I NO.31",
                NO_PROP= 32,
                NAMA_LGKP_IBU= "SURAIDA",
                PROP_NAME= "JAWA BARAT",
                NO_KAB= 75,
                TGL_LHR= "1994-05-23",
                KEL_NAME= "SEPANJANGJAYA"
            }
        };
  }

}