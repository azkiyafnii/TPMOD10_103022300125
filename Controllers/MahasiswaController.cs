using Microsoft.AspNetCore.Mvc;

namespace MOD10_103022300125.Controllers;
[ApiController]
[Route("api/[controller]")]
public class MahasiswaController : ControllerBase
{
    // Mendeklarasikan list statis untuk menyimpan data mahasiswa
    private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
    {
        new Mahasiswa("LeBron James", "1302000001"),
        new Mahasiswa("Stephen Curry", "1302000002")
    };

    // GET: api/mahasiswa
    [HttpGet]
    public ActionResult<IEnumerable<Mahasiswa>> Get()
    {
        return mahasiswaList;
    }

    // GET: api/mahasiswa/{id}
    [HttpGet("{id}")] // Menandakan bahwa ini adalah metode untuk menangani permintaan GET dengan parameter id
    public ActionResult<Mahasiswa> Get(int id)
    {
        if (id < 0 || id >= mahasiswaList.Count)
        {
            return NotFound();
        }
        return mahasiswaList[id];
    }

    // POST: api/mahasiswa
    [HttpPost]
    public ActionResult<IEnumerable<Mahasiswa>> Post([FromBody] Mahasiswa mahasiswa) 
    {
        mahasiswaList.Add(mahasiswa);
        return mahasiswaList; 
    }

    // DELETE: api/mahasiswa/{id}
    [HttpDelete("{id}")]
    public ActionResult<IEnumerable<Mahasiswa>> Delete(int id) 
    {
        if (id < 0 || id >= mahasiswaList.Count) 
        {
            return NotFound()
        }
        mahasiswaList.RemoveAt(id)
        return mahasiswaList; // Mengembalikan daftar mahasiswa yang diperbarui
    }
}
