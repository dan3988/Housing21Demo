using Demo.Website.Interfaces;

namespace Demo.Website;

public record CurrentUserService(string CurrentUser) : ICurrentUserService;
