titles=(
  "Create S3 bucket"
  "Create .NET Aspire solution structure"
  "Set up Docker Compose (3 containers)"
  "Verify containers communicate"
  "Enable pgvector extension"
  "Set up MongoDB collections"
  "EF Core models and migrations"
  "Seed Affirm company record"
  "Test file upload to S3"
)
label="infrastructure"
milestone="Phase 0: Foundation"
assignee="@me"

for title in "${titles[@]}"; do
  gh issue create --title "$title" \
    --label "$label" \
    --milestone "$milestone" \
    --assignee "$assignee"
done