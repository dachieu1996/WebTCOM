export interface ResponseResult {
    message: string;
    error: string;
    data: any;
    totalRecord: number;
    metadata?: any;
    totalCount?: number;
    status?: number;
    success?: boolean;
}