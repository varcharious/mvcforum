﻿using MVCForum.Domain.Constants;

namespace MVCForum.Domain
{
    public enum UrlType
    {
        Category,
        Topic,
        Member
    }

    public static class UrlTypes
    {
        public static string UrlTypeName(UrlType e)
        {
            switch (e)
            {
                case UrlType.Topic:
                    return AppConstants.TopicUrlIdentifier;
                case UrlType.Member:
                    return AppConstants.MemberUrlIdentifier;
                default:
                    return AppConstants.CategoryUrlIdentifier;
            }
        }

        public static string GenerateUrl(UrlType e, string slug)
        {
            return string.Format("/{0}/{1}", UrlTypeName(e), slug);
        }
    }
}