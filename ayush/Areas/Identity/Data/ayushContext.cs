using ayush.Configuration;
using ayush.Models;
using ayush.Models.admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static ayush.Models.PassiveCareer;

namespace ayush.Data
{
    public class ayushContext : IdentityDbContext<IdentityUser>
    {
        public ayushContext(DbContextOptions<ayushContext> options) : base(options) { }
        public DbSet<AddAdmin> AddAdmin { get; set; }
        public DbSet<AddStudent> AddStudent { get; set; }
        public DbSet<AddSchoolInfo> AddSchoolInfos { get; set; }
        public DbSet<AddSchool> AddSchool { get; set; }
        public DbSet<AddCounsellor> AddCounsellor { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<UserSibling> UserSiblings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<SystemInformation> SystemInformation { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<OneTimePassword> OneTimePasswords { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<StudentQuiz> StudentQuizzes { get; set; }
        public DbSet<AttemptedQuestion> AttemptedQuestions { get; set; }
        public DbSet<AttemptedOption> AttemptedOptions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<StudentModuleOneMarks> StudentModuleOneMarks { get; set; }
        public DbSet<StudentModuleTwoMarks> StudentModuleTwoMarks { get; set; }
        public DbSet<StudentModuleThreeMarks> StudentModuleThreeMarks { get; set; }
        public DbSet<StudentModuleFourMarks> StudentModuleFourMarks { get; set; }
        public DbSet<StudentModuleFiveMarks> StudentModuleFiveMarks { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<StudentSlot> StudentSlots { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<PassiveCareer> PassiveCareers { get; set; }
        public DbSet<InterestModuleQuestion6UserCareer> InterestModuleQuestion6UserCareers { get; set; }
        public DbSet<InterestModuleQuestion7UserCareer> InterestModuleQuestion7UserCareers { get; set; }
        public DbSet<InterestModuleQuestion8UserCareer> InterestModuleQuestion8UserCareers { get; set; }
        public  DbSet<BaseUser> BaseUsers { get; set; }
        public DbSet<FeedbackFormModel> Feedback { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<RewardsRegister> RewardsRegister { get; set; }
        public DbSet<CaseStudy> CaseStudy { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserInformationConfiguration());
            builder.ApplyConfiguration(new UserSiblingConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new SystemInformationConfiguration());
            builder.ApplyConfiguration(new NotificationConfiguration());
            builder.ApplyConfiguration(new OneTimePasswordConfiguration());
            
            builder.Entity<PassiveCareer>(entity =>
            {
                entity.Property(x => x.CareerListType).HasDefaultValue(ListType.ListA);
            });
            
            base.OnModelCreating(builder);
        }
    }
}
