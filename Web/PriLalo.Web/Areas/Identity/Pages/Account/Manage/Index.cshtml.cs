namespace PriLalo.Web.Areas.Identity.Pages.Account.Manage
{
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using PriLalo.Data.Common.Repositories;
    using PriLalo.Data.Models;

    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userRepository = userRepository;
        }

        public string Username { get; set; }

        [Display(Name = "��������� ���")]
        public string FirstName { get; set; }

        [Display(Name = "������� ���")]
        public string LastName { get; set; }

        [Display(Name = "����")]
        public string Town { get; set; }

        [Display(Name = "�����")]
        public string Address { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "��������� �����")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await this.userManager.GetUserNameAsync(user);
            var phoneNumber = await this.userManager.GetPhoneNumberAsync(user);

            var userAdress = user.Address;
            var userTown = user.Town;
            var firstName = user.FirstName;
            var lastName = user.LastName;

            this.Username = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Town = userTown;
            this.Address = userAdress;

            this.Input = new InputModel
            {
                PhoneNumber = phoneNumber,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID '{this.userManager.GetUserId(this.User)}'.");
            }

            await this.LoadAsync(user);
            return this.Page();
        }

        public async Task<IActionResult> OnPostAsync(string userName, string address, string town, string firstName, string lastName)
        {
            var user = await this.userManager.GetUserAsync(this.User);
            if (user == null)
            {
                return this.NotFound($"Unable to load user with ID '{this.userManager.GetUserId(this.User)}'.");
            }

            if (!this.ModelState.IsValid)
            {
                await this.LoadAsync(user);
                return this.Page();
            }

            var phoneNumber = await this.userManager.GetPhoneNumberAsync(user);
            if (this.Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await this.userManager.SetPhoneNumberAsync(user, this.Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    this.StatusMessage = "Unexpected error when trying to set phone number.";
                    return this.RedirectToPage();
                }
            }

            user.NormalizedUserName = userName.ToUpper();
            user.UserName = userName;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Town = town;
            user.Address = address;

            this.userRepository.Update(user);
            await this.userRepository.SaveChangesAsync();

            await this.signInManager.RefreshSignInAsync(user);
            this.StatusMessage = "������ ������ ���� ������������.";
            return this.RedirectToPage();
        }
    }
}
