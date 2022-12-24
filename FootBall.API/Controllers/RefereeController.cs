using FootBall.API.Context;
using FootBall.API.Entity;
using FootBall.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootBall.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefereeController : ControllerBase
    {
        private readonly UserContext db;

        public RefereeController(UserContext db)
        {
            this.db = db;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Referee>>> GetAll()
        {
            return await this.db.Referee.ToListAsync();
        }

        [HttpGet("[action]/{Id}")]
        public async Task<ActionResult<CreateRefereeModel>> GetById(int id)
        {
            Referee referee = await this.db.Referee.FirstOrDefaultAsync(x => x.Id == id);

            if (referee == null)
                return NotFound();

            return new ObjectResult(referee);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<Referee>> Create([FromQuery] Referee referee)
        {
            if (referee == null)
                return this.BadRequest();

            db.Referee.Add(referee);

            await this.db.SaveChangesAsync();

            return Ok(referee);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<CreateRefereeModel>> Update([FromQuery] Referee referee)
        {
            if (referee == null)
                return this.BadRequest();

            if (!db.Referee.Any(x => x.Id == referee.Id))
                return this.NotFound();

            db.Referee.Update(referee);
            await db.SaveChangesAsync();

            return Ok(referee);
        }

        [HttpDelete("[action]/{Id}")]
        public async Task<ActionResult<CreateRefereeModel>> Delete(int id)
        {
            Referee referee = await this.db.Referee.FirstOrDefaultAsync(x => x.Id == id);

            if (id < 0)
                return NotFound();

            db.Referee.Remove(referee);
            await db.SaveChangesAsync();
            return Ok(referee);
        }
    }
}

