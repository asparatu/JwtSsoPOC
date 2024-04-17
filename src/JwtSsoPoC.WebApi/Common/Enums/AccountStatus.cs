using System.Diagnostics;

using Ardalis.SmartEnum;

namespace JwtSsoPoC.WebApi.Common.Enums;

public abstract class AccountStatus : SmartEnum<AccountStatus>
{
    public static readonly AccountStatus Unknown = new UnknownType();
    public static readonly AccountStatus Active = new ActiveType();
    public static readonly AccountStatus Deleted = new DeletedType();
    public static readonly AccountStatus Disabled = new DisabledType();
    public static readonly AccountStatus Inactive = new InactiveType();
    public static readonly AccountStatus Locked = new LockedType();
    public static readonly AccountStatus PendingApproval = new PendingApprovalType();
    public static readonly AccountStatus Suspended = new SuspendedType();
    public static readonly AccountStatus Unverified = new UnverifiedType();

    protected AccountStatus(string name, int value) : base(name, value) { }
    protected AccountStatus() : base("default", 0) { }

    private sealed class UnknownType : AccountStatus
    {
        public UnknownType() : base("Unknown", 0) { }
    }

    private sealed class ActiveType : AccountStatus
    {
        public ActiveType() : base("Active", 1) { }
    }

    private sealed class DeletedType : AccountStatus
    {
        public DeletedType() : base("Deleted", 2) { }
    }

    private sealed class DisabledType : AccountStatus
    {
        public DisabledType() : base("Disabled", 4) { }
    }

    private sealed class InactiveType : AccountStatus
    {
        public InactiveType() : base("Inactive", 8) { }
    }

    private sealed class LockedType : AccountStatus
    {
        public LockedType() : base("Locked", 16) { }
    }

    private sealed class PendingApprovalType : AccountStatus
    {
        public PendingApprovalType() : base("Pending Approval", 32) { }
    }

    private sealed class SuspendedType : AccountStatus
    {
        public SuspendedType() : base("Suspended", 64) { }
    }

    private sealed class UnverifiedType : AccountStatus
    {
        public UnverifiedType() : base("Unverified", 128) { }
    }
}